using System.ComponentModel;
using System.Threading.Channels;

namespace Perseus.Mvvm.Tests
{
    public partial class NotificationObjectTests
    {

        #region Changed


        #region Event

        [Test]
        public void PropertyChanged_EventInvoked()
        {
            Car car = new()
            {
                Make = "Toyota",
                Model = "Camry"
            };

            PropertyChangedEventArgs? changed = null;
            car.PropertyChanged += (_, arg) =>
            {
                if(changed != null)
                {
                    return;
                }

                changed = arg;
            };

            car.Model = "Corolla";

            Assert.Multiple(() =>
            {
                Assert.That(changed, Is.Not.Null);
                Assert.That(changed?.PropertyName, Is.EqualTo(nameof(Car.Model)));
            });
        }

        [Test]
        public void PropertyDidNotChange_EventNotInvoked()
        {
            Car car = new()
            {
                Make = "Toyota",
                Model = "Camry"
            };

            PropertyChangedEventArgs? changed = null;
            car.PropertyChanged += (_, arg) =>
            {
                changed = arg;
            };

            car.Model = "Camry";

            Assert.That(changed, Is.Null);
        }

        #endregion


        #region Action

        [Test]
        public void PropertyChanged_ActionInvoked()
        {
            Car car = new()
            {
                Make = "Toyota",
                Model = "Camry"
            };

            bool hit = false;
            car.OnChanged = () => hit = true;

            car.Model = "Corolla";

            Assert.That(hit, Is.True);
        }

        [Test]
        public void PropertyDidNotChange_ActionNotInvoked()
        {
            Car car = new()
            {
                Make = "Toyota",
                Model = "Camry"
            };

            bool hit = false;
            car.OnChanged = () => hit = true;

            car.Model = "Camry";

            Assert.That(hit, Is.False);
        }

        #endregion


        #endregion


        #region Changing


        #region Event

        [Test]
        public void PropertyChanging_EventInvoked()
        {
            Car car = new()
            {
                Make = "Toyota",
                Model = "Camry"
            };

            PropertyChangingEventArgs? changing = null;
            car.PropertyChanging += (_, arg) =>
            {
                if(changing != null)
                {
                    return;
                }

                changing = arg;
            };

            car.Model = "Corolla";

            Assert.Multiple(() =>
            {
                Assert.That(changing, Is.Not.Null);
                Assert.That(changing?.PropertyName, Is.EqualTo(nameof(Car.Model)));
            });
        }

        [Test]
        public void PropertyNotChanging_EventNotInvoked()
        {
            Car car = new()
            {
                Make = "Toyota",
                Model = "Camry"
            };

            PropertyChangingEventArgs? changing = null;
            car.PropertyChanging += (_, arg) =>
            {
                changing = arg;
            };

            car.Model = "Camry";

            Assert.That(changing, Is.Null);
        }

        #endregion


        #region Action

        [Test]
        public void PropertyChanging_ActionInvoked()
        {
            Car car = new()
            {
                Make = "Toyota",
                Model = "Camry"
            };

            bool hit = false;
            car.OnChanging = () => hit = true;

            car.Model = "Corolla";

            Assert.That(hit, Is.True);
        }

        [Test]
        public void PropertyNotChanging_ActionNotInvoked()
        {
            Car car = new()
            {
                Make = "Toyota",
                Model = "Camry"
            };

            bool hit = false;
            car.OnChanging = () => hit = true;

            car.Model = "Camry";

            Assert.That(hit, Is.False);
        }

        #endregion


        #endregion


        #region Validation

        [Test]
        public void ValidationPassed()
        {
            Car car = new()
            {
                Make = "Toyota",
                Model = "Camry"
            };

            string newModel = "Corolla";

            bool hit = false;
            car.OnValidate = (oldVal, newVal) =>
            {
                hit = true;
                return true;
            };

            car.Model = newModel;

            Assert.Multiple(() =>
            {
                Assert.That(hit, Is.True);
                Assert.That(car.Model, Is.EqualTo(newModel));
            });
        }

        [Test]
        public void ValidationNotPassed()
        {
            Car car = new()
            {
                Make = "Toyota"
            };

            string oldModel = "Camry";
            string newModel = "Corolla";

            car.Model = oldModel;

            bool hit = false;
            car.OnValidate = (oldVal, newVal) =>
            {
                hit = true;
                return false;
            };

            car.Model = newModel;

            Assert.Multiple(() =>
            {
                Assert.That(hit, Is.True);
                Assert.That(car.Model, Is.Not.EqualTo(newModel));
                Assert.That(car.Model, Is.EqualTo(oldModel));
            });
        }

        #endregion


        #region Propagation

        [Test]
        public void PropertyChanged_PropagatesWithAttribute()
        {
            Car car = new()
            {
                Make = "Nissan"
            };

            PropertyChangedEventArgs? changed = null;
            car.PropertyChanged += (_, arg) =>
            {
                if(arg.PropertyName == nameof(Car.MakeAndModel))
                {
                    changed = arg;
                }
            };

            car.Model = "Z";

            Assert.That(changed, Is.Not.Null);
        }

        [Test]
        public void PropertyChanged_DoesNotPropagateWithoutAttribute()
        {
            Car car = new()
            {
                Make = "Nissan"
            };

            PropertyChangedEventArgs? changed = null;
            car.PropertyChanged += (_, arg) =>
            {
                if(arg.PropertyName == nameof(Car.MakeAndModelNoAttribute))
                {
                    changed = arg;
                }
            };

            car.Model = "Z";

            Assert.That(changed, Is.Null);
        }

        #endregion

    }
}