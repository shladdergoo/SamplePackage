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

            Assert.NotNull(worker.DoWork());
        }

        [Fact]
        public void MoreWork_Returns()
        {
            Worker worker = new Worker();

            Assert.NotNull(worker.MoreWork());
        }

        [Fact]
        public void EvenMoreWork_Returns()
        {
            Worker worker = new Worker();

            Assert.NotNull(worker.EvenMoreWork());
        }
    }
}
