package com.evil.corporation.sdk.no.source;

public final class SomeImportantFinalClass {
	
	private final static String THE_IMPORTANT_STRING;

	static { // contrived example... circumvent compiler inlining of static final string
		THE_IMPORTANT_STRING = "Java Drools and C# Rules!";
	}
	
	public String getTheImprotantString() { return THE_IMPORTANT_STRING; }
	
}
