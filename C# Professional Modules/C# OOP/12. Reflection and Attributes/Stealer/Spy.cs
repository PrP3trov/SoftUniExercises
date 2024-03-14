using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fileds)
        {
            Type classType = Type.GetType(className);
            FieldInfo[] classFields = classType.GetFields((BindingFlags)60);
            StringBuilder st = new StringBuilder();

            Object classIsnstance = Activator.CreateInstance(classType, new object[]{ });

            st.AppendLine($"Class under investigation: {className}");

            foreach (var field in classFields.Where(f => fileds.Contains(f.Name)))
            {
                st.AppendLine($"{field.Name} = {field.GetValue(classIsnstance)}");
            }
            return st.ToString().Trim();
        }
    }
}
