using System.Reflection;
using System.Globalization;

namespace Calculator
{

	using System;

	public class CalcEngine
	{
		//
		// Operation Constants.
		//
		public enum Operator:int
		{
			eUnknown = 0,
			eAdd = 1,
			eSubtract = 2,
			eMultiply = 3,
			eDivide = 4,
             // новые операторы
            ePower = 5,
            eSqrt = 6,
            eReciprocal = 7,
            eSquare = 8,       
            eFactorial = 9,
            eCbrt = 10
        }

		//
		// Module-Level Constants
		//

		private static double negativeConverter = -1;

		private static string versionInfo = "Calculator v3.0.1.1";

		//
		// Module-level Variables.
		//
	
		private static double numericAnswer;
		private static string stringAnswer;
		private static Operator calcOperation;
		private static double firstNumber;
		private static double secondNumber;
		private static bool secondNumberAdded;
		private static bool decimalAdded;
 
		//
		// Class Constructor.
		//
		public CalcEngine ()
		{
			decimalAdded = false;
			secondNumberAdded = false;
		}

		//
		// Returns the custom version string to the caller.
		//

		public static string GetVersion ()
		{
			return (versionInfo);
		}
		//
		// Called when the Date key is pressed.
		//
		public static string GetDate ()
		{
			DateTime curDate = new DateTime();
			curDate = DateTime.Now;

			stringAnswer = String.Concat (curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

			return (stringAnswer);
		}

		//
		// Called when a number key is pressed on the keypad.
		//

		public static string CalcNumber (string KeyNumber)
		{
			stringAnswer = stringAnswer + KeyNumber;
			return (stringAnswer);
		}

		//
		// Called when an operator is selected (+, -, *, /)
		//

		public static void CalcOperation (Operator calcOper)
		{
			if (stringAnswer != "" && !secondNumberAdded)
			{
                //firstNumber = System.Convert.ToDouble (stringAnswer); не поддерживало точку
                firstNumber = double.Parse(stringAnswer, CultureInfo.InvariantCulture);
                calcOperation = calcOper;
				stringAnswer = "";
				decimalAdded = false;
			}			
		}

		//
		// Called when the +/- key is pressed.
		//

		public static string CalcSign ()
		{
			double numHold;

			if (stringAnswer != "")
			{
                //numHold = System.Convert.ToDouble (stringAnswer);
                //stringAnswer = System.Convert.ToString(numHold * negativeConverter);
                numHold = double.Parse(stringAnswer, CultureInfo.InvariantCulture);
                stringAnswer = (numHold * negativeConverter).ToString(CultureInfo.InvariantCulture);


            }

            return (stringAnswer);
		}

		//
		// Called when the . key is pressed.
		//

		public static string CalcDecimal ()
		{
			if (!decimalAdded && !secondNumberAdded)
			{
				if (stringAnswer != "")
					stringAnswer = stringAnswer + ".";
				else
					stringAnswer = "0.";

				decimalAdded = true;
			}

			return (stringAnswer);
		}

		//
		// Called when = is pressed.
		//

		public static string CalcEqual ()
		{
			bool validEquation = false;

			if (stringAnswer != "")
			{
                // secondNumber = System.Convert.ToDouble (stringAnswer);
                secondNumber = double.Parse(stringAnswer, CultureInfo.InvariantCulture);
                secondNumberAdded = true;

				switch (calcOperation)
				{
					case Operator.eUnknown:
						validEquation = false;
						break;

					case Operator.eAdd:
						numericAnswer = firstNumber + secondNumber;
						validEquation = true;
						break;

					case Operator.eSubtract:
						numericAnswer = firstNumber - secondNumber;
						validEquation = true;
						break;

					case Operator.eMultiply:
						numericAnswer = firstNumber * secondNumber;
						validEquation = true;
						break;

					case Operator.eDivide:
						numericAnswer = firstNumber / secondNumber;
						validEquation = true;
						break;
						//степень
                    case Operator.ePower:
                        numericAnswer = Math.Pow(firstNumber, secondNumber);
                        validEquation = true;
                        break;
                    default:
						validEquation = false;
						break;
				}

				//if (validEquation)
				//	stringAnswer = System.Convert.ToString (numericAnswer);
                if (validEquation)
                    stringAnswer = numericAnswer.ToString(CultureInfo.InvariantCulture);
            }
			
			return (stringAnswer);
		}

		//
		// Resets the various module-level variables for the next calculation.
		//

		public static void CalcReset ()
		{
			numericAnswer = 0;
			firstNumber = 0;
			secondNumber = 0;
			stringAnswer = "";
			calcOperation = Operator.eUnknown;
			decimalAdded = false;
			secondNumberAdded = false;			
		}
		//вычисление корня
        public static string CalcSqrt()
        {
            if (stringAnswer == "") return stringAnswer;

            double x = double.Parse(stringAnswer, CultureInfo.InvariantCulture);
            if (x < 0) { stringAnswer = "Ошибка"; return stringAnswer; }

            stringAnswer = Math.Sqrt(x).ToString(CultureInfo.InvariantCulture);
            return stringAnswer;
        }
        //возведение в квадрат
        public static string CalcSquare()
        {
            if (stringAnswer == "") return stringAnswer;

            double x = double.Parse(stringAnswer, CultureInfo.InvariantCulture);
            stringAnswer = (x * x).ToString(CultureInfo.InvariantCulture);
            
			return stringAnswer;
        }
		// обратное значение
        public static string CalcReciprocal()
        {
            if (stringAnswer == "") return stringAnswer;

            double x = double.Parse(stringAnswer, CultureInfo.InvariantCulture);
            if (x == 0) { stringAnswer = "Ошибка"; return stringAnswer; }

            stringAnswer = (1.0 / x).ToString(CultureInfo.InvariantCulture);

            return stringAnswer;
        }
		// факториал
        public static string CalcFactorial()
        {
            if (stringAnswer == "" || stringAnswer == "Ошибка") return stringAnswer;

            double x = double.Parse(stringAnswer, CultureInfo.InvariantCulture);

            // Факториал только для целых и неотрицательных
            if (x < 0 || Math.Abs(x - Math.Round(x)) > 1e-12)
            {
                stringAnswer = "Ошибка";
                return stringAnswer;
            }

            int n;
            try { n = checked((int)Math.Round(x)); }
            catch { stringAnswer = "Ошибка"; return stringAnswer; }

            // Ограничение, чтобы не улететь в бесконечность
            if (n > 170) { stringAnswer = "Ошибка"; return stringAnswer; }

            double res = 1.0;
            for (int i = 2; i <= n; i++) res *= i;

            stringAnswer = res.ToString(CultureInfo.InvariantCulture);
            return stringAnswer;
        }
		// кубический корень
        public static string CalcCbrt()
        {
            if (stringAnswer == "" || stringAnswer == "Ошибка") return stringAnswer;

            double x = double.Parse(stringAnswer, CultureInfo.InvariantCulture);

            double res = x >= 0 ? Math.Pow(x, 1.0 / 3.0) : -Math.Pow(-x, 1.0 / 3.0);

            stringAnswer = res.ToString(CultureInfo.InvariantCulture);
            return stringAnswer;
        }
    }
}