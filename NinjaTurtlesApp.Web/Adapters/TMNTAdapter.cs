using NinjaTurtlesApp.Data;
using NinjaTurtlesApp.Data.Models;
using NinjaTurtlesApp.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjaTurtlesApp.Web.Adapters
{
    public class TMNTAdapter : INinjaTurtle
    {
        public NinjaTurtle GetTurtle(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            return Db.Turtles.Where(t => t.Id == id).FirstOrDefault();
        }

        public void CreateTurtle(string name, string color, string description, string pictureLg, string pictureSm, string personality, string weapons)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            NinjaTurtle Turtle = new NinjaTurtle(name, color, description, pictureLg, pictureSm, personality, weapons);
            Db.Turtles.Add(Turtle);
            Db.SaveChanges();

        }

        public List<NinjaTurtle> GetAllTurtles()
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            return Db.Turtles.ToList();
        }

        public void DeleteTurtle(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            NinjaTurtle Turtle = Db.Turtles.Where(t => t.Id == id).FirstOrDefault();
            Db.Turtles.Remove(Turtle);
            Db.SaveChanges();
        }

        public void EditTurtle(int id, string name, string color, string description, string pictureLg, string pictureSm, string personality, string weapons)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            NinjaTurtle NinjaTurtle = Db.Turtles.Where(t => t.Id == id).FirstOrDefault();
            NinjaTurtle.Name = name;
            NinjaTurtle.Color = color;
            NinjaTurtle.Description = description;
            NinjaTurtle.PictureLg = pictureLg;
            NinjaTurtle.PictureSm = pictureSm;
            NinjaTurtle.Personality = personality;
            NinjaTurtle.Weapons = weapons;
            Db.SaveChanges();

        }

    }
}