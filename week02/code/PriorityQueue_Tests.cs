using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue one item and dequeue it
    // Expected Result: The dequeued value should match the enqueued value
    // Defect(s) Found: (leave blank or write "None" after testing)
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(100, 5);           // value 100, priority 5

        int result = priorityQueue.Dequeue();

        Assert.AreEqual(100, result, "Dequeued value should be 100");
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities → dequeue should give highest priority first
    // Expected Result: Dequeue returns items in descending priority order
    // Defect(s) Found: (fill in after running) 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(10, 1);   // low priority
        priorityQueue.Enqueue(30, 5);   // high
        priorityQueue.Enqueue(20, 3);   // medium

        Assert.AreEqual(30, priorityQueue.Dequeue(), "Should dequeue highest priority first (30)");
        Assert.AreEqual(20, priorityQueue.Dequeue(), "Next should be 20");
        Assert.AreEqual(10, priorityQueue.Dequeue(), "Last should be 10");
    }

    // Add more test cases as needed below.
    // - Enqueue same priority → any order is ok
    // - Dequeue from empty → exception
    // - Many items, etc.
}