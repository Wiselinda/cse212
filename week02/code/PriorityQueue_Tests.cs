using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add 3 items with different priorities
    // Expected Result: The item with the highest priority is dequeued
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("High", 3);

        var dequeued = priorityQueue.Dequeue();
        Assert.AreEqual("High", dequeued);
    }

    [TestMethod]
    // Scenario: Add 3 items where two share the highest priority
    // Expected Result: The first of the highest priority items is dequeued (FIFO)
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 3);
        priorityQueue.Enqueue("Third", 5);

        var dequeued = priorityQueue.Dequeue();
        Assert.AreEqual("First", dequeued);
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: Exception is thrown
    // Defect(s) Found: None
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected exception was not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }
}