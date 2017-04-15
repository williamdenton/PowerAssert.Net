using System;
using System.Reflection;

namespace PowerAssert
{
	internal static class ReflectionShim
	{
		public static bool IsEnum(Type type)
		{
#if(NET40)
			return type.IsEnum;
#else
			return type.GetTypeInfo().IsEnum;
#endif
		}

		public static bool IsGenericType(Type type)
		{
#if(NET40)
			return type.IsGenericType;
#else
			return type.GetTypeInfo().IsGenericType;
#endif
		}

		public static Assembly Assembly(Type type)
		{
#if(NET40)
			return type.Assembly;
#else
			return type.GetTypeInfo().Assembly;
#endif
		}

		public static PropertyInfo[] GetProperties(Type type)
		{
#if(NET40)
			return type.GetProperties();
#else
			return type.GetTypeInfo().GetProperties();
#endif
		}

		public static PropertyInfo GetProperty(Type type, string name)
		{
#if(NET40)
			return type.GetProperty(name);
#else
			return type.GetTypeInfo().GetProperty(name);
#endif
		}

		public static Type[] GetInterfaces(Type type)
		{
#if(NET40)
			return type.GetInterfaces();
#else
			return type.GetTypeInfo().GetInterfaces();
#endif
		}

		public static Type GetGenericTypeDefinition(Type type)
		{
#if(NET40)
			return type.GetGenericTypeDefinition();
#else
			return type.GetTypeInfo().GetGenericTypeDefinition();
#endif
		}

		public static ParameterInfo[] GetMethodParameters(Delegate method)
		{
#if(NET40)
			return method.Method.GetParameters();
#else
			return method.GetMethodInfo().GetParameters();
#endif
		}

		public static Type MethodReturnType(Delegate method)
		{
#if(NET40)
			return method.Method.ReturnType;
#else
			return method.GetMethodInfo().ReturnType;
#endif
		}

		public static MethodInfo GetMethod(Type type, string name, BindingFlags bindingAttr)
		{
#if(NET40)
			return type.GetMethod(name, bindingAttr);
#else
			return type.GetTypeInfo().GetMethod(name, bindingAttr);
#endif
		}

		public static MethodInfo GetMethod(Type type, string name, Type[] types)
		{
#if(NET40)
			return type.GetMethod(name, types);
#else
			return type.GetTypeInfo().GetMethod(name, types);
#endif
		}

		public static Type[] GetGenericArguments(Type type)
		{
#if(NET40)
			return type.GetGenericArguments();
#else
			return type.GetTypeInfo().GetGenericArguments();
#endif
		}

		public static MethodInfo[] GetMethods(Type type)
		{
#if(NET40)
			return type.GetMethods();
#else
			return type.GetTypeInfo().GetMethods();
#endif
		}

		public static MethodInfo[] GetMethods(Type type, BindingFlags bindingAttr)
		{
#if(NET40)
			return type.GetMethods(bindingAttr);
#else
			return type.GetTypeInfo().GetMethods(bindingAttr);
#endif
		}

		public static bool IsAssignableFrom(Type typeFrom, Type typeTo)
		{
#if(NET40)
			return typeFrom.IsAssignableFrom(typeTo);
#else
			return typeFrom.GetTypeInfo().IsAssignableFrom(typeTo);
#endif
		}
	}
}