using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: no test was implemented.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Alice", 10);
        priorityQueue.Enqueue("Bob", 22);
        priorityQueue.Enqueue("Charlie", 50);

        Assert.AreEqual("Charlie", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Alice", priorityQueue.Dequeue());
       
        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 5);
        priorityQueue.Enqueue("D", 1);

       Assert.AreEqual("B", priorityQueue.Dequeue()); 
       Assert.AreEqual("C", priorityQueue.Dequeue()); 
       Assert.AreEqual("A", priorityQueue.Dequeue()); 
       Assert.AreEqual("D", priorityQueue.Dequeue()); 
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}