﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    class Book
    {
        public string name;
        public int sides;
        public bool hardcover;
        public string category;

        private string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return name;
            }
        }
        private int Sides
        {
            set
            {
                this.sides = value;
            }
            get
            {
                return sides;
            }
        }
        private bool Hardcover
        {
            set
            {
                this.hardcover = value;
            }
            get
            {
                return hardcover;
            }
        }
        private string Category
        {
            set
            {
                this.category = value;
            }
            get
            {
                return category;
            }
        }
        public Book()
        {

        }
        public Book(string inputname, int inputside, bool inputhardcover, string inputcategory)
        {
            this.name = inputname;
            this.sides = inputside;
            this.hardcover = inputhardcover;
            this.category = inputcategory;
        }
        static List<Book> books = new List<Book>();//mn bog liste på biblioteket
        
        public void addbooks()//tilføjer alle bøgerne 
        {
            books.Add(new Book("Bog1", 200, true, "Crime"));
            books.Add(new Book("Bog2", 20, false, "Disney"));
            books.Add(new Book("Bog3", 100, true, "Crime"));
            books.Add(new Book("Cisco Network", 600, true, "Boring"));
            books.Add(new Book("Bog5", 90, true, "Crime"));
            books.Add(new Book("Bog6", 180, true, "True-Crime"));
            books.Add(new Book("Bog7", 150, true, "Crime"));
            books.Add(new Book("Bog8", 10, true, "Disney"));
            books.Add(new Book("Bog9", 50, true, "Disney"));
            books.Add(new Book("Bog10", 250, true, "True-Crime"));

        }

        public void seeall()//metode til at se alle bøgerne på hylderne
        {
            foreach (var item in books)
            {
                Console.WriteLine("Navn: " + item.name + " Antal sider: " + item.sides + " Hårdt omslag: " + item.hardcover + " Kategori: " + item.category);
            }
        }
        public Book Lendbooks(string findnameinput)//låner bøgerne
        {
            foreach (var item in books)
            {
                if (item.name == findnameinput)
                {
                    books.Remove(item);
                    return item;
                }

            }
            return null;
        }
    }
}
