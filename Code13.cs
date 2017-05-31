    //
    // Note: This is sample code for demonstration purposes only and is provided as-is.   
    //
[TestMethod]
public void AggregateLogs_PastThreeDays_ReturnsAllLinesFromPastThreeDaysAndToday()
{
    // Arrange
    var sut = new LogAggregator();
 
    // Act
    var result = sut.AggregateLogs(@"C:\SomeLogDir", daysInPast: 3);
 
    // Assert
    Assert.AreEqual(4, result.Length, "Number of aggregated lines incorrect.");
CollectionAssert.Contains(result, "ThreeDaysAgoFirstLine", "Expected line missing.");
CollectionAssert.Contains(result, "TodayLastLine", "Expected line missing.");
}