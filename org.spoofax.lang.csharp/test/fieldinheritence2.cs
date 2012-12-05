namespace FieldInheritence2 {
  partial class A {
    int a;
  }
  
  partial class B : A {
    int test() {
      return a;
    }
  }
}