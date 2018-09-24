/*
 * Created by SharpDevelop.
 * User: Артем
 * Date: 01.09.2018
 * Time: 18:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Drawing;

namespace TestDrawer
{
	/// <summary>
	/// Description of Shape.
	/// </summary>
	public abstract class Shape
	{
		public class Point
		{
			public int X {get; private set;}
			public int Y {get; private set;}
			
			public Point(int x, int y)
			{
				X = x;
				Y = y;
			}
		}
		public IReadOnlyCollection<Point> Points { get { return new ReadOnlyCollection<Point>(list);} }
		private readonly IList<Point> list = new List<Point>();
		
		public void AddPoint(int x, int y)
		{
			list.Add(new Point(x, y));
		}
	}
	
	public interface ICommand
	{
		void Execute();
	}
	
	public class Command<T> : ICommand
	{
		private readonly IDrawCommand<T> drawCommand;
		private readonly T shape;
		public Command(IDrawCommand<T> drawCommand, T shape)
		{
			this.drawCommand = drawCommand;
			this.shape = shape;
		}
		public void Execute()
		{
			if (drawCommand != null)
				drawCommand.Draw(shape);
		}
	}
	
	public interface ICommandProvider
	{
		ICommand GetDrawCommand(Graphics graphics);
	}
	
	public class CommandProvider<T> : ICommandProvider where T: Shape
	{
		private readonly T shape;		
		public CommandProvider(T shape)
		{
			this.shape = shape;
		}
		
		public ICommand GetDrawCommand(Graphics graphics) 
		{
			return new Command<T>(new DrawCommand(graphics), shape);
		}
	}
	
	public class Circle : Polygon
	{
		public Circle(int x, int y, int radius) : base(x,y, radius, radius)
		{
		}
	}
	
 	public class Square : Polygon
	{
 		public Square(int x, int y, int width) : base(x,y, width, width)
		{
		}
	}
 	
 	public class Triangle : Polygon
	{
 		public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
		{
			AddPoint(x1,y1);
			AddPoint(x2,y2);
			AddPoint(x3,y3);
		}
	}
 	
 	public class Polygon : Shape
	{
 		public Polygon(){}
		public Polygon(int x, int y, int width, int height) 
		{
			AddPoint(x,y);
			AddPoint(x + width, y);
			AddPoint(x + width, y+ height);
			AddPoint(x, y+ height);
		}
	}
 	
 	public interface IDrawCommand<in T>
 	{
 		void Draw(T Shape);
 	}
 
 	public class NotSupportedDrawCommand : IDrawCommand<Shape>
 	{
 		public void Draw(Shape shape)
 		{
 			throw new NotSupportedException();
 		} 	
 	}
 	
 	public class DrawCommand : NotSupportedDrawCommand, IDrawCommand<Circle>, IDrawCommand<Polygon>
 	{
 		private readonly Graphics graphics;
 		public DrawCommand(Graphics graphics)
 		{
 			this.graphics = graphics;
 		}
 				
 		public void Draw(Circle shape)
 		{
 			using (var pen = new Pen(Color.Black))
 			{
 				var points = shape.Points;
 				graphics.DrawEllipse(pen, new RectangleF(new PointF(points.ElementAt(0).X, points.ElementAt(0).Y), new SizeF(points.ElementAt(2).X - points.ElementAt(0).X, points.ElementAt(2).Y - points.ElementAt(0).Y)));
 			}
 		} 

 		public void Draw(Polygon shape)
 		{
 			using (var pen = new Pen(Color.Black))
 			{
 				var points = shape.Points;
 				graphics.DrawPolygon(pen, points.Select(p => new PointF(p.X, p.Y)).ToArray());
 			}
 		} 
 	}
}
