using System;
using System.Collections.Generic;
using System.Linq;

namespace IMQ1.ACSHARP.SimpleFloor.Simple
{
    /// <summary>
    /// Simple floor.
    /// </summary>
    public static class SimpleFloor
    {
        /// <summary>
        /// Gets or sets the floor numbers.
        /// </summary>
        /// <value>
        /// The floor numbers.
        /// </value>
        private static IEnumerable<int> FloorNumbers { get; set; } = new List<int>();

        /// <summary>
        /// Gets the floor of simple numbers.
        /// </summary>
        /// <param name="count">The count.</param>
        /// <returns>Floor of sum of simple numbers.</returns>
        public static decimal GetFloorOfSimpleNumbers(int count)
        {
            return CalculateFloor(GetSimpleNumbers(count));
        }

        /// <summary>
        /// Gets the simple numbers.
        /// </summary>
        /// <param name="count">The count.</param>
        /// <returns>Collection of simple numbers.</returns>
        private static IEnumerable<int> GetSimpleNumbers(int count)
        {
            if (!FloorNumbers.Any())
            {
                FloorNumbers = GenerateList();
            }

            return FloorNumbers.Take(count);
        }

        /// <summary>
        /// Generates the list.
        /// </summary>
        /// <returns>Collection of simple numebrs.</returns>
        private static IEnumerable<int> GenerateList()
        {
            return Enumerable.Range(2, int.MaxValue - 1).Where(number => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => number % divisor != 0));
        }

        /// <summary>
        /// Calculates the floor.
        /// </summary>
        /// <param name="sequence">The sequence.</param>
        /// <returns>Floor of sum of simple numbers.</returns>
        private static decimal CalculateFloor(IEnumerable<int> sequence)
        {
            var listSequence = sequence.ToList();
            var sum = listSequence.Select((t, i) => (decimal)t / (i + 1)).Sum();
            return Math.Floor(sum);
        }
    }
}
