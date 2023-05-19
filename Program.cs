using System;

class Program
{
    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSequence(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }

    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Enter a half DNA sequence:");
            string halfDNASequence = Console.ReadLine();

            if (IsValidSequence(halfDNASequence))
            {
                Console.WriteLine("Current half DNA sequence: " + halfDNASequence);
                Console.Write("Do you want to replicate it? (Y/N): ");
                char choice = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (choice == 'Y')
                {
                    string replicatedSequence = ReplicateSequence(halfDNASequence);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                }
                else if (choice == 'N')
                {
                    // Skip replication
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            char programChoice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (programChoice == 'Y')
            {
                continueProgram = true;
            }
            else if (programChoice == 'N')
            {
                continueProgram = false;
            }
            else
            {
                Console.WriteLine("Please input Y or N.");
                continueProgram = true;
            }
        }
    }
}
