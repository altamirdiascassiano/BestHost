using NUnit.Framework;

namespace BestHost.BusinessRules.Test
{
    public class Tests
    {

        /*
         * 
         *
                 private HostAdminDB MapEntityToDBEntity(HostAdmin hostAdmin)
        {
            return new HostAdminDB()
            {
                Id= hostAdmin.Id,
                Name = hostAdmin.Name,
                VirtualName = hostAdmin.VirtualName,
                Age = hostAdmin.Age,
                EmailAddress = hostAdmin.EmailAddress,
                FacebookPage = hostAdmin.FacebookPage,
                PhoneNumber = hostAdmin.PhoneNumber
            };
        }
        */

            //metodo condicao resultaodo esperado  soma_qndoSomar1+1_deveRetornarASoma
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange 
            var x = 1;
            var y = 1;

            //Act
            var result = x + y;

            //Assert
            Assert.Pass(result==2);

        }
    }
}