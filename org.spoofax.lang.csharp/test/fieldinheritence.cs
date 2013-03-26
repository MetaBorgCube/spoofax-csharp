namespace FieldInheritence {
  partial class A {
    int a;
  }
  
  partial class B : A {
  }
  
  class C {
    B b;
    
    int test() {
      return b.a;
    }
  }
}