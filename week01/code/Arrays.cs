public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
{
    // Step 1: Create an array of doubles with size equal to 'length'.
    double[] result = new double[length];

    // Step 2: Loop from 0 to length - 1.
    for (int i = 0; i < length; i++)
    {
        // Step 3: For each index i, store number * (i + 1) in the array.
        result[i] = number * (i + 1);
    }

    // Step 4: Return the filled array.
    return result;
}
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
{
    // Step 1: Calculate the index to split the list: data.Count - amount
    int splitIndex = data.Count - amount;

    // Step 2: Use GetRange to get the last 'amount' items and store in a list
    List<int> rightPart = data.GetRange(splitIndex, amount);

    // Step 3: Use GetRange to get the rest of the items and store in a second list
    List<int> leftPart = data.GetRange(0, splitIndex);

    // Step 4: Clear the original list
    data.Clear();

    // Step 5: Add the rotated segments back into the original list
    data.AddRange(rightPart);
    data.AddRange(leftPart);
}
}