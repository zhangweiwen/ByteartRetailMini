using System;
using Autofac.Extras.DynamicProxy2;
using Castle.DynamicProxy;

namespace ByteartRetailMini.Test
{
    public class AopTest
    {
        public virtual int Add(int x, int y)
        {
            return x + y;
        }
    }

    public class LogInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();
            if (invocation.ReturnValue != null)
            {
                Console.WriteLine("Aop Output => {0}", invocation.ReturnValue);
            }
        }
    }
}