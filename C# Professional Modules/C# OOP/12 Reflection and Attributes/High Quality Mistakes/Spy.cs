using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        
        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);
            FieldInfo[] fields = classType.GetFields((BindingFlags)60);
            MethodInfo[] PublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] NonPublicMethods = classType.GetMethods((BindingFlags.NonPublic | BindingFlags.Instance));
            StringBuilder st = new StringBuilder();
            foreach (var field in fields)
            {
                if (field.IsPublic)
                {
                    st.AppendLine($"{field.Name} must be private!");
                }
            }
            foreach (var method in PublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                st.AppendLine($"{method.Name} have to be private!");
            }
            foreach (var method in NonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                st.AppendLine($"{method.Name} have be public!");
            }
            return st.ToString().Trim();
        }
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
