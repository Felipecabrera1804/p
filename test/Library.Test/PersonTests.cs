using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void Nombre_Correcto()
        {
            Person Jorge = new Person("Jorge Rial", "5.302.011-2");
            Assert.AreEqual("Jorge Rial" , Jorge.Name);
        }
        [Test]
        public void Cedula_Correcta()
        {
            Person Jorge = new Person("Jorge Rial", "5.302.011-2");
            Assert.AreEqual("5.302.011-2" , Jorge.ID);
        }
        [Test]
        public void Nombre_Vacio()
        {
            Person Jorge = new Person("", "5.302.011-2");
            Assert.AreEqual(null , Jorge.Name);
        }
        [Test]
        public void Cedula_Invalida()
        {
            Person Jorge = new Person("Jorge Rial", "5.302.011-1");
            Assert.AreEqual(null , Jorge.ID);
        }
    }
}