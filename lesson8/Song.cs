using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    internal class Song
    {
        private string name;
        private string author;
        private Song previousSong;
        /// <summary>
        /// Свойство для чтения поля name.
        /// </summary>
        public string Name 
        {
            get
            {
                return name;
            }
                
        }
        /// <summary>
        /// Свойство для чтения поля author.
        /// </summary>
        public string Author 
        {
            get
            {
                return author;
            }
        }
        /// <summary>
        /// Свойство для чтения поля prev.
        /// </summary>
        public Song PreviousSong 
        {
            get
            {
                return previousSong;
            }
        }
        /// <summary>
        /// Свойство для прочтения названия песни и ее автора.
        /// </summary>
        public string Title
        {
            get
            {
                return name + " - " + author;
            }
        }
        /// <summary>
        /// Метод, который сравнивает между собой два объекта-песни.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Song otherSong = (Song)obj;

            return Name == otherSong.Name && Author == otherSong.Author;
        }
        /// <summary>
        /// Метод, переопределяющий метод GetHashCode для класса Song.
        /// </summary>
        public override int GetHashCode()
        {
            return Title.GetHashCode() ^ Author.GetHashCode();
        }
        /// <summary>
        /// Конструктор, который создает новый экземпляр класса и заполняет его данными.
        /// </summary>
        public Song(string name, string author, Song previousSong) 
        {
            this.name = name;
            this.author = author;
            this.previousSong = previousSong;
        }
        /// <summary>
        /// Конструктор, который создает новый экземпляр класса и заполняет его данными.
        /// </summary>
        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;
            this.previousSong = null;
        }
        /// <summary>
        /// Конструктор, который создает новый экземпляр класса.
        /// </summary>
        public Song()
        {
            this.name = "Не указано";
            this.author = "Не указано";
            this.previousSong = null;
        }
    }
}
