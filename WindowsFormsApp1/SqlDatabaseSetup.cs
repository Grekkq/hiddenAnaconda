using System;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;

namespace hiddenAnaconda {
    [TestClass()]
    public class SqlDatabaseSetup
    {

        [AssemblyInitialize()]
        public static void InitializeAssembly(TestContext ctx)
        {
            // Setup the test database based on setting in the
            // configuration file
            SqlDatabaseTestClass.TestService.DeployDatabaseProject();
            SqlDatabaseTestClass.TestService.GenerateData();
        }

        private class AssemblyInitializeAttribute : Attribute {
        }
    }
}
