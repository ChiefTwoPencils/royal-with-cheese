package net.goody.two.shoes.rainbows.and.kittens;

import java.lang.reflect.Field;
import java.lang.reflect.Modifier;
import java.util.concurrent.ScheduledThreadPoolExecutor;
import java.util.concurrent.TimeUnit;

import com.evil.corporation.sdk.no.source.SomeImportantFinalClass;

public class SubvertTheEvilCorp {

	public static void main(String[] args) throws InterruptedException {
		
		final SomeImportantFinalClass sifc = new SomeImportantFinalClass();
		
		new ScheduledThreadPoolExecutor(1).schedule(() -> {
			try {
				Field theImportantString = sifc.getClass().getDeclaredField("THE_IMPORTANT_STRING");
				theImportantString.setAccessible(true);
				Field modifiersField = Field.class.getDeclaredField("modifiers");
				modifiersField.setAccessible(true);
				modifiersField.setInt(theImportantString, theImportantString.getModifiers() & ~Modifier.FINAL);
				theImportantString.set(null, "Java Rules, and C# Drools!");
			} catch (NoSuchFieldException | SecurityException | IllegalArgumentException | IllegalAccessException e) {
				// all exception thrown for things the JVM can be set to protect against
				e.printStackTrace();
			}
		}, 5, TimeUnit.SECONDS);
		
		while (true) {
			System.out.println(sifc.getTheImprotantString());
			Thread.sleep(1000);
		}
		
	}
	
}
