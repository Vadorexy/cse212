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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Check if length is 0, if so return an empty array
        if (length <= 0)
        {
            return [0];  // Return an empty array if no multiples are requested
        }

        // Step 2: Create an array to store the multiples values
        double[] multiples = new double[length];

        // Step 3: Loop through and calculate the value
        for (int i = 1; i <= length; i++)
        {
            multiples[i - 1] = number * i;   // 1, 2, 3,... Calculate and store the value
        }

        // Step 4: Return the array of multiples
        return multiples;  // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Understand the requirement.
        // We need to rotate the list to the right by amount positions, modifying the list in place.
        // Right rotation means the last 'amount' elements move to the front. 

        if (data == null || data.Count == 0)
        {
            return; // Nothing to do, amount would not be set.
        }

        // Step 2: Consider constraints.
        // amount is between 1 and data.Count inclusive.
        // If amount == data.Count, the list should remain unchanged.

        int n = data.Count;
        amount = amount % n; // Since amount <= n, only matters if amount == n -> 0.

        // Step 3: Choose an efficient method.
        // Use the three-reverse technique for O(n) time and O(1) extra space.

        if (amount == 0)
        {
            return; // No rotation needed.
        }

        // Reverse entire list
        data.Reverse(0, n);

        // Reverse first 'amount' elements
        data.Reverse(0, amount);

        // Reverse the rest
        data.Reverse(amount, n - amount);
    }
}
