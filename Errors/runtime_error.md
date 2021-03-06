# Ошибки на этапе выполнения

[Видео](https://youtu.be/Nn_Dba8MqB0)

## Заметки по лекции

Есть большое множество разнообразных ошибок на этапе выполнения. Вот несколько примеров:

### Null Reference Exception

Все поля заполняются значениями по умолчанию. Для типа string значение по умолчанию — null — отсутствие объекта.

Любая попытка обратиться к null вызывает исключение Null reference exception
```cs
class Program
{
	static string myString;

	static void Main()
	{
		Console.WriteLine(myString[0]);
	}
}
```

### Вложенные ошибки

В этом случае, исключение будет не информативным, а вся существенная информация об ошибке будет находиться в свойстве InnerException.

Однако лучше избегать такого рода ошибок, не выполняя сложных действий в инициализаторах статических полей.
```cs
class Program2
{
	static int variable = int.Parse(Console.ReadLine());

	static void Main()
	{
		Console.WriteLine(variable);
	}
}
```

### Деление на ноль

При делении целочисленного числа на целочисленный ноль, возникает исключение.

Любое исключение кроме сообщения об ошибке содержит в себе информацию о стеке вызовов, то есть последовательности вызывавшихся методов. Эта информация помогает локализовать проблему.
```cs
using System;

namespace DivisionByZeroSample
{
	class Program
	{
		static int Divide(int a, int b)
		{
			return a / b;
		}

		static void Main()
		{
			Console.WriteLine(Divide(1, 0));
		}

	}
}

/*
  Важная информация, которую можно извлечь из информации об исключении: 
    название, стек вызовов

  System.DivideByZeroException was unhandled  
  StackTrace:
       at S04.Program.Divide(Int32 a, Int32 b) in Program.cs:line 13
       at S04.Program.Main() in Program.cs:line 18
       at System.AppDomain._nExecuteAssembly(RuntimeAssembly assembly, String[] args)
       at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
       at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
       at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
       at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
       at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
       at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
       at System.Threading.ThreadHelper.ThreadStart()
  InnerException: 
*/
```
