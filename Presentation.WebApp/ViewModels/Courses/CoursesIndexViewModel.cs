using Presentation.WebApp.Models.Sections;

namespace Presentation.WebApp.ViewModels.Courses;

public class CoursesIndexViewModel
{
    public string Title { get; set; } = "Courses";

    //public ShowcaseModel Showcase { get; set; } = new ShowcaseModel
    //{
    //    Id = "overview",
    //    ShowcaseImage = new() { ImageUrl = "/images/home/showcase-taskmaster.svg", AltText = "Task Management Assistant" },
    //    Title = "Task Management Assistant You Gonna Love",
    //    Text = "We offer you a new generation of task management system. Plan, manage & track all your tasks in one flexible tool.",
    //    Link = new() { ControllerName = "Downloads", ActionName = "Index", Text = "Get started for free" },
    //    BrandsText = "Largest companies use our tool to work efficiently",
    //    Brands =
    //        [
    //            new() { ImageUrl = "/images/brands/brand_1.svg", AltText = "Brand Name 1" },
    //            new() { ImageUrl = "/images/brands/brand_2.svg", AltText = "Brand Name 2" },
    //            new() { ImageUrl = "/images/brands/brand_3.svg", AltText = "Brand Name 3" },
    //            new() { ImageUrl = "/images/brands/brand_4.svg", AltText = "Brand Name 4" },
    //        ]
    //};

    public CoursesModel Courses { get; set; } = new CoursesModel
    {

        Categories =
        [
            "All categories",
            "Web development",
            "Mobile development",
            "Game development",
            "Design",
            "Testing",
            "Data Science"
        ],
        CoursesDetails =
        [
            new()
            {
                CourseImage = new() { ImageUrl = "/images/courses/fullstack.svg", AltText = "Fullstack" },
                Badge = new() { ImageUrl = "/images/courses/badge.svg", AltText = "Best seller" },
                Icon = "fa-regular fa-bookmark",
                Title = "Fullstack Web Developer Course from Scratch",
                Author = "by Robert Fox",
                Price = 12.50,
                Duration = "220 hours",
                Rating = "94% (4.2K)"
            },
            new() { CourseImage = new() { ImageUrl = "/images/courses/web_developer.svg", AltText = "Web developer" }, Icon = "fa-regular fa-bookmark", Title = "HTML , CSS , JavaScript , Web  Developer", Author = "By Jenny Wilson & Marvin McKinney", Price = 15.99, Duration = "160 hours", Rating = "92% (3.1K)" },
            new() { CourseImage = new() { ImageUrl = "/images/courses/front_end.svg", AltText = "Frontend" }, Icon = "fa-regular fa-bookmark", Title = "The Complete Front-End Web Development Course", Author = "By Albert Flores", Price = 44.99, Discount = 9.99, Duration = "100 hours", Rating = "98% (2.7K)" },
            new() { CourseImage = new() { ImageUrl = "/images/courses/ios.svg", AltText = "ios" }, Icon = "fa-regular fa-bookmark", Title = "iOS & Swift - The Complete iOS App Development Course", Author = "By Marvin McKinney", Price = 15.99, Duration = "160 hours", Rating = "92% (3.1K)" },
            new()
            {
                CourseImage = new() { ImageUrl = "/images/courses/python.svg", AltText = "Python" },
                Badge = new() { ImageUrl = "/images/courses/badge.svg", AltText = "Best seller" },
                Icon = "fa-regular fa-bookmark",
                Title = "Data Science & Machine Learning with Python",
                Author = "By Esther Howard",
                Price = 11.20,
                Duration = "160 hours",
                Rating = "92% (3.1K)"
            },
            new() { CourseImage = new() { ImageUrl = "/images/courses/css.svg", AltText = "CSS" }, Icon = "fa-regular fa-bookmark", Title = "Creative CSS Drawing Course: Make Art With CSS", Author = "By Robert Fox", Price = 10.50, Duration = "220 hours", Rating = "94% (4.2K)" },
            new() { CourseImage = new() { ImageUrl = "/images/courses/blender.svg", AltText = "video games" }, Icon = "fa-regular fa-bookmark", Title = "Blender Character Creator v2.0 for Video Games Design", Author = "By Ralph Edwards", Price = 18.99, Duration = "160 hours", Rating = "92% (3.1K)" },
            new() { CourseImage = new() { ImageUrl = "/images/courses/unity.svg", AltText = "Unity" }, Icon = "fa-regular fa-bookmark", Title = "The Ultimate Guide to 2D Mobile Game Development with Unity", Author = "By Albert Flores", Price = 44.99, Discount = 12.50, Duration = "100 hours", Rating = "98% (2.7K)" },
            new() { CourseImage = new() { ImageUrl = "/images/courses/jmeter.svg", AltText = "JMETER" }, Icon = "fa-regular fa-bookmark", Title = "Learn JMETER from Scratch on Live Apps-Performance Testing", Author = "By Jenny Wilson", Price = 14.50, Duration = "160 hours", Rating = "92% (3.1K)" },


        ]
    };

}
