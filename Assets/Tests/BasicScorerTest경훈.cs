using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityDemo.Models.Scorers;
using UnityDemo.Models;

public class NewTestScript {

    [Test]
    public void 두_카드가_광인_경우()
    {
        Scorer scorer = new BasicScorer();

        Player player1 = new Player("1");
        player1.AddCard(new Card(1, true));
        player1.AddCard(new Card(3, true));

        Player player2 = new Player("2");
        player2.AddCard(new Card(8, true));
        player2.AddCard(new Card(3, true));

        Player winner = scorer.GetWinner(player1, player2);

        Assert.AreEqual(player2, winner);

    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }
}
