using System;
namespace BookManagementAppliction.Models
{
    /// <summary>
    /// lop book dung de luu thong tin can thiet cua 1 cuon sach
    /// </summary>
    public class Book
    {
        private int _id = 1;
        private string _authors = "Unknow author";
        private string _title = "A new book";
        private string _publisher = "No publicsher";
        private int _year = 2020;
        private int _edition = 1;
        private string _file;

        public int Id
        {
            get { return _id; }
            set { if (value >= 1) _id = value; }
        }
        public string Authors
        {
            get => _authors;
            set { if (!string.IsNullOrEmpty(value)) _authors = value; }
        }
        public string Title
        {
            get => _title;
            set { if (!string.IsNullOrEmpty(value)) _title = value; }
        }
        public string Publisher
        {
            get => _publisher;
            set { if (!string.IsNullOrEmpty(value)) _publisher = value; }
        }
        public int Year
        {
            get => _year;
            set { if (value > 1950) _year = value; }        }
        public int Edition
        {
            get => _edition;
            set { if (_edition > 1) _edition = value; }
        }
        public string Isbn { get; set; } = "";
        public string Tags { get; set; } = "";
        public string Description { get; set; } = "A new book";
        public int Rating { get; set; } = 1;
        public bool Reading { get; set; }
        public string File
        {
           get => _file;
            set { if (System.IO.File.Exists(_file)) _file = value; }
        }
        public string FileName
        {
            get { return System.IO.Path.GetFileName(_file); }
        }
    }
}
