using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Threading;

namespace KnowledgeBase.Examples.Benchmarks.MultithreadingBenchmarks;

/// <summary>
/// A class for testing performance when using synchronization primitives.
/// </summary>
public class SynchronizationPrimitivesBenchmark
{
    private int counter = 0;
    private volatile int counterVolatile = 0;
    private object lockObject = new object();
    private SpinLock spinLock = new SpinLock();

    [Benchmark]
    public void TestLock()
    {
        lock (lockObject)
        {
            counter++;
        }
    }

    [Benchmark]
    public void TestInterlocked()
    {
        Interlocked.Increment(ref counter);
    }

    [Benchmark]
    public void TestSpinLock()
    {
        bool lockTaken = false;
        spinLock.Enter(ref lockTaken);
        counter++;
        spinLock.Exit();
    }

    [Benchmark]
    public void TestVolatile()
    {
        counterVolatile++;
    }
}