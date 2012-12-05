namespace Overriding {
  class A {
    int f() {
      return 0;
    }
  }
  class B : A {
    int f() { 
      return 1;
    }
  }
}