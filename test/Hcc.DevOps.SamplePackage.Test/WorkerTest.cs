using System;

using Xunit;

using Hcc.DevOps.SamplePackage;

namespace Hcc.DevOps.SamplePackage.Test
{
    public class WorkerTest
    {
        [Fact]
        public void DoWork_Returns()
        {
            Worker worker = new Worker();

            Assert.Equal("foo", worker.DoWork());
        }
    }
}
