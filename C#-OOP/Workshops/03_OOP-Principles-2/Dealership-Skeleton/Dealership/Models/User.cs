using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Bytes2you.Validation;
using System.Text.RegularExpressions;

namespace Dealership.Models
{
    public class User : IUser
    {
        private string username;
        private string firstName;
        private string lastName;
        private string password;
        private Role role;
        private IList<IVehicle> vehicles;
        public User(string username, string firstName, string lastName, string password, string role)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = (Role)Enum.Parse(typeof(Role), role);
            this.vehicles = new List<IVehicle>();
        }
        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Username cannot be null or empty!", nameof(value));
                }
                else if(!Regex.IsMatch(value, @"^[a-zA-Z0-9]+$"))
                {
                    throw new ArgumentException("Username contains invalid symbols!");
                }
                else if(value.Length < 2 || value.Length > 20)
                {
                    throw new ArgumentException("Username must be between 2 and 20 characters long!");
                }
                this.username = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Firstname cannot be null or empty!", nameof(value));
                }
                else if (value.Length < 2 || value.Length > 20)
                {
                    throw new ArgumentException("Firstname must be between 2 and 20 characters long!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Lastname cannot be null or empty!", nameof(value));
                }
                else if (value.Length < 2 || value.Length > 20)
                {
                    throw new ArgumentException("Lastname must be between 2 and 20 characters long!");
                }
                this.lastName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Password cannot be null or empty!", nameof(value));
                }
                else if (value.Length < 5 || value.Length > 30)
                {
                    throw new ArgumentException("Password must be between 5 and 30 characters long!");
                }
                this.password = value;
            }
        }

        public Role Role
        {
            get { return this.role; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentException("Role cannot be null or empty!", nameof(value));
                }
                this.role = value;
            }
        }

        public IList<IVehicle> Vehicles => this.vehicles;

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            if(commentToAdd == null)
            {
                throw new ArgumentNullException("The comment cannot be null!");
            }
            if(vehicleToAddComment == null)
            {
                throw new ArgumentNullException("The vehicle to add comment to cannot be null!");
            }
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            if(vehicle == null)
            {
                throw new ArgumentNullException("The vehicle to add cannot be null!");
            }
            if(this.Role != Role.VIP && this.Vehicles.Count == 5)
            {
                throw new ArgumentException("You are not VIP and cannot add more than 5 vehicles!");
            }
            if(this.Role == Role.Admin)
            {
                throw new ArgumentException("You are an admin and therefore cannot add vehicles!");
            }
            this.Vehicles.Add(vehicle);
        }

        public string PrintVehicles()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"--USER {Username}--");

            if(this.Vehicles.Count < 1)
            {
                sb.AppendLine("--NO VEHICLES--");
            }
            else
            {
                int countVehicles = 1;

                foreach (var vehicle in Vehicles)
                {
                    sb.Append($"{countVehicles}. ");
                    sb.AppendLine(vehicle.ToString());

                    if(vehicle.Comments.Count < 1)
                    {
                        sb.AppendLine("    --NO COMMENTS--");
                    }
                    else
                    {
                        sb.AppendLine("    --COMMENTS--");
                        foreach (var comment in vehicle.Comments)
                        {
                            sb.AppendLine(comment.ToString());
                        }
                        sb.AppendLine("    --COMMENTS--");
                    }
                    countVehicles++;
                }
            }
            return sb.ToString();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if (commentToRemove == null)
            {
                throw new ArgumentNullException(nameof(commentToRemove));
            }

            if (vehicleToRemoveComment == null)
            {
                throw new ArgumentNullException(nameof(vehicleToRemoveComment));
            }

            if (commentToRemove.Author != this.username)
            {
                throw new ArgumentException("You are not the author!");
            }

            vehicleToRemoveComment.Comments.Remove(commentToRemove);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException("Vehicle cannot be null!");
            }
            this.Vehicles.Remove(vehicle);
        }
        public override string ToString()
        {
            return $"Username: {Username}, FullName: {FirstName} {LastName}, Role: {Role}";
        }
    }
}
