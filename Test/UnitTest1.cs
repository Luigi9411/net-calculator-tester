using net_calculator_tester;

namespace Test
{
    public class Tests
    {
        Calculator db;

        [SetUp]
        public void Setup()
        {
            db = new Calculator();
        }

        [Test]
        [Description("Verifico con due float inventanti che la somma torni")]
        public void Add_()
        {
            float num1 = 2;
            float num2 = 3;
            float Result = 5;

            float result = db.Add(num1, num2);

            Assert.AreEqual(Result, result);
        }

        [Test]
        [Description("Verifico con due float inventanti che la sottrazione torni")]
        public void Insert_SubtractWithoutError()
        {
            float num1 = 6;
            float num2 = 2;
            float Result = 4;

            float result = db.  Subtract(num1, num2);

            Assert.AreEqual(Result, result);
        }

        [Test]
        [Description("Verifico con due float inventanti che la divisione torni")]
        public void Insert_DivideWithoutError()
        {
            float num1 = 6;
            float num2 = 2;
            float Result = 3;

            float result = db.Divide(num1, num2);

            Assert.AreEqual(Result, result);
        }

        [Test]
        [Description("Verifico con due float inventanti che la moltiplicazione torni")]
        public void Insert_MultiplyWithoutError()
        {
            float num1 = 6;
            float num2 = 2;
            float Result = 12;

            float result = db.Multiply(num1, num2);

            Assert.AreEqual(Result, result);
        }
    }
}