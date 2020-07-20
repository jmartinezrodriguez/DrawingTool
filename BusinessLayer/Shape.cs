using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Shape : IDraw
    {
        public Canva canva { get; set; }
        public Line line { get; set; }
        public Rectangle rectangle { get; set; }


        public Shape DrawShape(string[] data)
        {
            Shape shape = new Shape();
            int width = 0;
            int height = 0;
            string type = string.Empty;

            try
            {
                if (data.Length > 0)
                {
                    foreach (var item in data)
                    {
                        string[] coordinates = Utility.TextManager(item, " ");
                        type = coordinates[0];

                        if (!string.IsNullOrEmpty(type))
                        {
                            if (type.ToUpper().Equals((Utility.CANVAS)))
                            {
                                width = int.Parse(coordinates[1]);
                                height = int.Parse(coordinates[2]);
                                shape.canva = new Canva() { Width = width, Height = height };
                            }

                            if (type.ToUpper().Equals(Utility.LINE))
                            {
                                shape.line = new Line() { Width = width, Height = height, X1 = int.Parse(coordinates[1]), Y1 = int.Parse(coordinates[2]), X2 = int.Parse(coordinates[3]), Y2 = int.Parse(coordinates[4]) };
                            }


                            if (type.ToUpper().Equals(Utility.RECTANGLE))
                            {
                                shape.rectangle = new Rectangle() { Width = width, Height = height, X1 = int.Parse(coordinates[1]), Y1 = int.Parse(coordinates[2]), X2 = int.Parse(coordinates[3]), Y2 = int.Parse(coordinates[4]) };
                            }
                        }
                    }
                }

                return shape;

            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
