package csharp.strategies;

import org.spoofax.interpreter.terms.IStrategoTerm;
import org.strategoxt.lang.Context;
import org.strategoxt.lang.Strategy;

public class record_time_native_0_1 extends Strategy {
	public static record_time_native_0_1 instance = new record_time_native_0_1();

	@Override
	public IStrategoTerm invoke(Context context, IStrategoTerm current, IStrategoTerm name) {
		return current;
	}
}
