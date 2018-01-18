using Bytes2you.Validation;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class Comment : IComment
    {
        private string content;
        private string author;
        public Comment(string content)
        {
            this.Content = content;
        }
        public string Content
        {
            get
            {
                return this.content;
            }
            set
            {
                if(value.Length < 3 || value.Length > 200)
                {
                    throw new ArgumentException("Content must be between 3 and 200 characters long!");
                }
                else if (value == null)
                {
                    throw new ArgumentNullException("Content cannot be null or empty");
                }
                this.content = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.author = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"    ----------\n{Content}\n      User: {Author}\n    ----------");

            return sb.ToString().TrimEnd();
        }
    }
}