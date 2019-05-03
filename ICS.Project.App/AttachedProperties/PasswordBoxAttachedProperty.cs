using System.Security;
using System.Windows;

namespace ICS.Project.App.AttachedProperties
{
    public class PasswordBoxAttachedProperty
    {
        public static readonly DependencyProperty EncryptedPasswordProperty =
            DependencyProperty.RegisterAttached("EncryptedPassword", typeof(SecureString),
                typeof(PasswordBoxAttachedProperty));

        public static SecureString GetEncryptedPassword(DependencyObject obj)
        {
            return (SecureString) obj.GetValue(EncryptedPasswordProperty);
        }

        public static void SetEncryptedPassword(DependencyObject obj, SecureString value)
        {
            obj.SetValue(EncryptedPasswordProperty, value);
        }
    }
}