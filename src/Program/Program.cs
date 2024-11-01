﻿using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> i1 = new Node<int>(1);
            Node<int> i2 = new Node<int>(2);
            Node<int> i3 = new Node<int>(3);
            Node<int> i4 = new Node<int>(4);
            Node<int> i5 = new Node<int>(5);
            Node<int> i6 = new Node<int>(6);
            Node<int> i7 = new Node<int>(7);
            
            i1.AddChildren(i2);
            i1.AddChildren(i3);
            
            i2.AddChildren(i4);
            i2.AddChildren(i5);
            
            i3.AddChildren(i6);
            i3.AddChildren(i7);
            
            
            Person p1 = new Person("Pedro", 76);
            Node<Person> n1 = new Node<Person>(p1);
            
            Person p2 = new Person("Ana", 50);
            Node<Person> n2 = new Node<Person>(p2);
            
            Person p3 = new Person("Juan", 48);
            Node<Person> n3 = new Node<Person>(p3);
            
            Person p4 = new Person("Carlos", 44);
            Node<Person> n4 = new Node<Person>(p4);
            
            Person p5 = new Person("Eustaquio", 6);
            Node<Person> n5 = new Node<Person>(p5);
            
            Person p6 = new Person("Yo", 8);
            Node<Person> n6 = new Node<Person>(p6);
            
            Person p7 = new Person("Gioconda Rodriguez Del Campo", 3);
            Node<Person> n7 = new Node<Person>(p7);
            
            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n4);
            n2.AddChildren(n5);
            n2.AddChildren(n6);
            n3.AddChildren(n7);

            Visitor visitor = new Visitor();
            
            Console.WriteLine(n1.AcceptAgeSumVisitor(visitor,n1));
            Console.WriteLine(n1.AcceptEldestChildVisitor(visitor, n1));
            Console.WriteLine(n1.AcceptLongestNameVisitor(visitor, n1));

        }
    }
}
