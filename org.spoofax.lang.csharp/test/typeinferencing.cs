namespace TypeInferencing {
  class A {
    int test() {
      var a = woot();
      var b = inc(a);
      return b;
    }
    int woot() { return 1; }
    int inc(int i) { return i + 1; }
  }
}   