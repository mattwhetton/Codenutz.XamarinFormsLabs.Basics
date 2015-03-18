# Codenutz.XamarinFormsLabs.Basics

This project is a set of simple demonstration and starter projects for Xamarin Forms Labs. For more detailed coverage see http://www.codenutz.com/tag/xamarin-forms-labs/

##Step 1 XAML, MVVM & IOC

The first solution has a basic Xamarin Forms Labs set-up with a XAML view, using the MVVM pattern. The solution also sets up IOC with the SimpleContainer, and makes use of the ViewFactory for creating the Views and ViewModels.

The set-up is complete for Android and iOS, although there is still and outstanding issue with Xamarin Forms Labs preventing Windows Phone from building.

####Features included

- Basic Set-up
- MVVM
- ViewModel base class
- ViewFactory
- SimpleContainer (for Inversion of Control / Resolver)

##Step 2 Dependency Injection

Step 2 builds on step 1 but also includes implementation and usage of the SimpleContainer for dependency injection. The solution also gets device specific information via the IDevice interface. 

####Features Included

- SimpleContainer for Dependency Injection
- Usage of the IDevice implementation for Android, iOS and Windows Phone

###Step 2(a-d) Dependency Injection Containers

Steps 2a to 2d build on the core step 2 and include implementation of several dependency injection containers:

- a. Autofac
- b. Ninject
- c. TinyIoC
- d. Unity
