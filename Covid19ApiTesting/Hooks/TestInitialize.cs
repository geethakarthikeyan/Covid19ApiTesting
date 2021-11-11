using Covid19ApiTesting.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19ApiTesting.Hooks
{
    class TestInitialize
    {
        private Settings _settings;
        public TestInitialize(Settings settings)
        {
            _settings = settings;
        }

    }
}
