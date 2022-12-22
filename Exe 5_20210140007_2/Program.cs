// C# program for insertion and
// deletion in Circular Queue
using System;
using System.Collections.Generic;

 class Queues
{

	// Structure of a Node
	public class Node
	{
		public int data;
		public Node link;
	}

	public class LinkedList
	{
		public Node front, rear;
	}

	// Function to create Circular queue
	public void insert(LinkedList q,
							int value)
	{
		Node temp = new Node();
		temp.data = value;
		if (q.front == null)
		{
			q.front = temp;
		}
		else
		{
			q.rear.link = temp;
		}

		q.rear = temp;
		q.rear.link = q.front;
	}

	// Function to delete element from
	// Circular Queue
	public static int remove(LinkedList q)
	{
		if (q.front == null)
		{
			Console.Write("Queue is empty");
			return int.MinValue;
		}

		// If this is the last node to be deleted
		int value; // Value to be dequeued
		if (q.front == q.rear)
		{
			value = q.front.data;
			q.front = null;
			q.rear = null;
		}
		else // There are more than one nodes
		{
			Node temp = q.front;
			value = temp.data;
			q.front = q.front.link;
			q.rear.link = q.front;
		}

		return value;
	}

	// Function displaying the elements
	// of Circular Queue
	public  void display(LinkedList q)
	{
		Node temp = q.front;
		Console.Write("\nElements in Circular Queue are: ");
		while (temp.link != q.front)
		{
			Console.Write("{0:D} ", temp.data);
			temp = temp.link;
		}
		Console.Write("{0:D}", temp.data);
	}

	// Driver Code
	static void Main(string[] args)
	{
		Queues q = new Queues();
		char ch;
		while (true)
		{
			try
			{
				Console.WriteLine("Menu");
				Console.WriteLine("1. Implement insert operation");
				Console.WriteLine("2. Implement delete operation");
				Console.WriteLine("3. Display values");
				Console.WriteLine("4. Exit");
				Console.WriteLine("\nEnter your choice (1-4): ");
				ch = Convert.ToChar(Console.ReadLine());
				Console.WriteLine();
				switch (ch)
				{
					case '1':
						{
							Console.Write("Enter a number: ");
							int num = Convert.ToInt32(System.Console.ReadLine());
							Console.WriteLine();
							q.insert(num);
						}
						break;
					case '2':
						{
							q.remove();
						}
						break;
					case '3':
						{
							q.display();
						}
						break;
					case '4':
						return;
					default:
						{
							Console.WriteLine("Invalid option!!");
						}
						break;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Check for the values entered.");
			}
		}
	}
}

