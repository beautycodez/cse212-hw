using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: a last item with high priority is added to the queue in second possition
    // Expected Result: [intel, rxo, paramount, xpo];
    // Defect(s) Found: the code was not deleting or removin the items in the list. Additionally, there was an issue with the for loop, it was not
    // taking the last item in the list.

    public void TestPriorityQueue_1()
    {
        var intel = new PriorityItem("intel", 5);
        var paramount = new PriorityItem("paramount", 4);
        var xpo = new PriorityItem("xpo", 4);
        var rxo = new PriorityItem("rxo", 5);

        PriorityItem[] expectedResult = [intel, rxo, paramount, xpo];

        var players = new PriorityQueue();
        players.Enqueue(intel.Value, intel.Priority);
        players.Enqueue(paramount.Value, paramount.Priority);
        players.Enqueue(xpo.Value, xpo.Priority);
        players.Enqueue(rxo.Value, rxo.Priority);

        Console.WriteLine(players.GetType());

        for (var i = 0; i < 4; i++)
        {
            var item = players.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
        }
    }

    [TestMethod]
    // Scenario: Verify the queue is not empty conditional works correctly.
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue(); // Esto debería lanzar una excepción
            Assert.Fail("No se lanzó la excepción esperada cuando la cola estaba vacía.");
        }
        catch (InvalidOperationException ex)
        {
            // Validar que se capturó la excepción correcta
            Assert.AreEqual("The queue is empty.", ex.Message, "El mensaje de excepción no coincide.");
        }
    }

    // Add more test cases as needed below.
}