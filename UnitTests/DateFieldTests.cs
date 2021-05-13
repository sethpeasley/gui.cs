using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;


// Alias Console to MockConsole so we don't accidentally use Console
using Console = Terminal.Gui.FakeConsole;

namespace Terminal.Gui.Views 
{
    public class DateFieldTests
    {

        
        // [Fact]
        // public void SethsGUITestForTesting()
        // {
            
        //     Console.WriteLine("      \n\n   !!!!!!!!!!! yes  !!!!!!!!!!!!!!!!!!!!! \n\n");
        //     Assert.True(true);
        // }


        //  [Trait("GuiViewsYYYY", "DateField")]
        // // [Fact(DisplayName = "DateField initialized with no parameters")
        // [Fact]
        // public void TestATest()
        // { 
        //     // Arrange
        //     var df = new DateField();

        //     // Act
        //     var minDate = DateTime.MinValue;
        //   //  Console.WriteLine();

        //     Console.WriteLine("      \n\n   !!!!!!!!!!! wooooooo  !!!!!!!!!!!!!!!!!!!!! \n\n");

        //     // Assert
        //     Assert.True(true);
        // }

        /// <summary>
        /// Tests the Constructor with no parameters
        /// </summary>
        [Fact(DisplayName = "DateField Constructor with no parameters")]
        [Trait("GUIViews", "DateField Constructor with no parameters")]
        public void Constructor_With_No_Parameters()
        {
            // Arrange, Act, Assert

            var df = new DateField();

            var minDate = DateTime.MinValue;

            Assert.Equal(minDate, df.Date); 
            Assert.True(df.IsShortFormat); 
        }

        /// <summary>
        /// Tests the Constructor with Datetime struct parameter
        /// </summary>
        [Fact(DisplayName = "DateField Constructor with Datetime struct parameter")]
        [Trait("GUIViews", "DateField Constructor with Datetime struct parameter")]
        public void Constructor_With_Datetime_Struct()
        {
            // Arrange, Act, Assert

            var localDateTime = new DateTime(2003, 11, 10, 14, 23, 32);
            var df = new DateField(localDateTime);

            Assert.Equal(localDateTime.Day, df.Date.Day);
            Assert.Equal(localDateTime.Month, df.Date.Month); 
            Assert.Equal(localDateTime.Year, df.Date.Year);
            Assert.Equal(10, df.Width);
            Assert.True(df.IsShortFormat);
        }


        /// <summary>
        /// Tests the Constructor with absolute layout and Datetime object, with long date
        /// </summary>
        [Fact(DisplayName = "DateField Constructor with absolute layout and Datetime struct parameter, with long date")]
        [Trait("GUIViews", "DateField Constructor with absolute layout and Datetime struct parameter, with long date")]
        public void Constructor_With_Absolute_Layout_And_Datetime_Struct_And_Short()
        {
            // Arrange, Act, Assert

            var localDateTime = new DateTime(1997, 08, 22, 7, 57, 28);
            var x_coordinate = 22;
            var y_coordinate = 83;
            var df = new DateField(x_coordinate, y_coordinate, localDateTime);

            Assert.Equal(x_coordinate, df.X);
            Assert.Equal(y_coordinate, df.Y);

            Assert.Equal(localDateTime.Day, df.Date.Day);
            Assert.Equal(localDateTime.Month, df.Date.Month); 
            Assert.Equal(localDateTime.Year, df.Date.Year);
            Assert.False(df.IsShortFormat);
        }


    }
}

/*


public bool IsShortFormat 

public override bool ProcessKey (KeyEvent kb)

public override bool MouseEvent (MouseEvent ev)

public virtual void OnDateChanged (DateTimeEventArgs<DateTime> args)

public DateTimeEventArgs (T oldValue, T newValue, string format)

*/