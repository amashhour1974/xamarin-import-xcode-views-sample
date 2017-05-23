# Xamarin-Import-Xcode-Views-Sample
Simple sample showing and describing the best process to reuse iOS views created in Xcode and import them to Xamarin.iOS project 

Simple step by step instruction for importing Storyboards from Xcode to Xamarin Studio:
1. Add the Xcode Storyboard file to Xamarin Studio Xamarin.iOS project

2. For each View in that imported Storyboard go to Identity properties and repeat steps 3 to 6

3. Ctrl+X the value of `Class` property  

4. Remove the value of `Module` property

5. Ctrl+V the original value of `Class` property back to the text field  

6. Press Enter to trigger the change of value and automatically generate a `.cs` and `.designer.cs` files for your `ViewController`  

7. For each of the newly generated `*.cs` files make sure to create an implementation of all the `Actions` declared as `partial void` methods in corresponding `*.designer.cs` files

<br>
<br>

## Detailed description ##

### **Reusing existing Storyboards from Xcode to Xamarin Studio Xamarin.iOS project** ###

As you can see in screenshot bellow, CarnaLife iOS application developed by MedApp with Swift in Xcode already consists multiple views developed with Storyboards.

![CarnaLife Lite iOS application written in Swift in Xcode](/images/MedApp/Xamarin/1_inked.jpg)  
*CarnaLife Lite iOS application written in Swift with Xcode*

We decided that it will save us a lot of time if we could import those views from Xcode to Xamarin Studio. Our first thought was that somebody probably already done that and so we searched for any kind of documentation or tutorials on the internet. We were surprised to find out that there is nothing to be found in that subject and so we decided to try to find our own way to deal with it.

After a quick research we found out that Storyboards and XIB files are defined by XML and what's even more interesting, both Xcode and Xamarin/Visual Studio share the exact same scheme for those XMLs which in theory means that Storyboards and XIB files can be used interchangeably between Xcode and Xamarin/Visual Studio.

![Storyboards XML source](/images/MedApp/Xamarin/1_1.png)  
*Storyboards and XIB views are defined in XML*

For the POC purpose we prepared a simple Storyboard in Xcode with only 4 views defined inside.

![Simple Storyboard in Xcode](/images/MedApp/Xamarin/2.png)  
*Simple Storyboard with 4 ViewControllers for POC purpose*

After creating a new Xamarin.iOS project in Xamarin Studio we simply added that `MainCopy.storyboard` file into the solution.

![Adding MainCopy.storyboard to Xamarin.iOS project](/images/MedApp/Xamarin/4.png)  
*Adding `MainCopy.storyboard` to Xamarin.iOS project*

The whole process went pretty smooth and we were able open that storyboard inside Xamarin Studio without any issues. All the views and controls where there and everything looked ok.

![Xcode Storyboard opened in Xamarin Studio](/images/MedApp/Xamarin/5_inked.jpg)  
*Xcode Storyboard opened in Xamarin Studio*

![ViewControllers details](/images/MedApp/Xamarin/6.png)  
*ViewControllers details*

It looked so good we decided to give it a test run... which ended up with an exception...

![Exception](/images/MedApp/Xamarin/7.png)  
*Exception after first test run*

This one was on us though... we simply forgot to change `Main Interface` property in `Info.plist` file.  
We fixed it quickly by setting it to the newly imported Storyboard and gave it a shot.  


![Editing Info.plist file](/images/MedApp/Xamarin/8.png)  
*Editing `Info.plist` file*

Another test run, another fail...  
That `NSUnknownKeyException` bothered us for a really long time and we struggled for hours to get it right and find the right approach for it.


![NSUnknownKeyException](/images/MedApp/Xamarin/9.png)  
*`NSUnknownKeyException`*


After a while we figured out that we're definitely missing some code behind files for `ViewControllers` defined in that Storyboard.  
Instead of creating them from scratch we found out that there is an easy way of generating them automatically with Xamarin Studio.  
In order for Xamarin Studio to regenerate that `ViewController` class it is crucial to change the value of `Class` property and either press enter or change focus from that text field to something else and then put the original value back to that text field and press enter again. That somehow triggers Xamarin Studio to automatically generate a `.cs` file for that `ViewController`.

![Generating ViewController](/images/MedApp/Xamarin/10.png)  
*Generating ViewController*

After a while we discovered that the best approach is to simply:   
1. Ctrl+X the value of `Class` property  
2. Press Enter to trigger the change and notify Xamarin Studio about it  
3. Ctrl+V the original value of `Class` property back to the text field  
4. Press Enter to trigger the change of value and automatically generate a `.cs` file for your `ViewController`  
<br>

![Generating ViewController](/images/MedApp/Xamarin/11.png)  
*Generating ViewController*

What Xamarin Studio generates for us is a `*.cs` file and `*.designer.cs` file.  
- `*.cs` file implements a partial definition of `ViewController` class. That's basically our code behind

- `*.designer.cs` file also includes a partial definition of `ViewController` class but what it also does is that it registers that class to work with native Obj-C libs and it also holds a definition of all the controls and actions defined in a `View` so we can reference them from code behind by simply using their names

![*.designer.cs file](/images/MedApp/Xamarin/12.png)  
*`*.designer.cs` file with definitions of controls and actions linked with the `View`*

As you can see in the picture above and below, these definitions are linked 1:1 between Storyboard and `ViewController` designer class and now whenever I make any change in the name of any control in that `View` it will automatically update my `*.designer.cs` file.  
And that means we shouldn't make any changes in designer files because they might be regenerated and our changes will be lost.

![Sample control with Name property set to loginImageLabel](/images/MedApp/Xamarin/13.png)  
*Sample control with `Name` property set to `loginImageLabel` value*

Even though we managed to generate that `ViewController` class properly we still faced the same error.  
After countless tries, creating new projects, starting from scratch multiple times, trying out different names and namespaces for the project we were not moving forward at all.

![NSUnknownKeyException](/images/MedApp/Xamarin/14.png)  
*`NSUnknownKeyException`*

After few hours of investigation we finally found the source of that exception.  
The true reason of that error to show up was caused by a value set for `Module` property of `ViewController`.  
It turned out that this value was somehow screwing up Xamarin.iOS application.

![Module property](/images/MedApp/Xamarin/15.png)  
*`Module` property*

Luckly there was a very simple solution to that and all we had to do was to remove that value from `Module` field.

![Deleted value of Module property](/images/MedApp/Xamarin/16.png)  
*Deleted value of `Module` property*

After that fix our application run successfully for the first time.  
The whole UI was in place and everything seemed to work well... except for the buttons...  


![First successull run](/images/MedApp/Xamarin/17.png)  
*First successull run*

Whenever we tried to click a button it caused the application to crash with following exception:

![NSInvalidArgumentException](/images/MedApp/Xamarin/18.png)  
*`NSInvalidArgumentException`*

Luckly for us we managed to find the root of this issue pretty fast.  
It turned out that all the actions/events from our `View` were defined as `partial void` methods without any implementation.

![Designer and actions definitions](/images/MedApp/Xamarin/19.png)  
*Designer and actions definitions*

What we had to do in order to solve this was to create implementations for those actions in `ViewController` class definition.

![Creating emergencyLoginTapped action implementation](/images/MedApp/Xamarin/21.png)  
*Creating `emergencyLoginTapped` action implementation*

![Implementations for all the actions](/images/MedApp/Xamarin/22.png)  
*Implementations for all the actions*

That last fix made our UI to finally work and behave as we would expect it.  


![Final running application](/images/MedApp/Xamarin/23.png)  
*Running application*
