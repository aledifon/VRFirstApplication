# VR Interaction Prototype

A personal Unity XR prototype created to explore and implement fundamental interaction patterns for virtual reality applications.

The project focuses on experimenting with different ways of interacting with virtual objects and user interfaces using Unity's XR interaction system.

## Features

* Direct interaction with virtual objects
* Poke-based interaction
* Ray-based interaction for VR user interfaces
* Multiple interactor management using XR Interaction Groups
* Interactive doors and drawers
* Socket-based object placement
* VR locomotion and interaction setup
* Controller-based input and object manipulation

## Technical Details

* **Engine:** Unity 2022.3 LTS
* **Language:** C#
* **Platform:** PC VR
* **XR:** Unity XR interaction system

The project was initially developed with Unity 6.3 LTS. During development, I encountered noticeable stuttering and migrated the project to Unity 2022.3 LTS, rebuilding the scene on top of the VR template to obtain a more stable development environment.

## What I Explored

The purpose of this prototype was not to build a complete VR application, but to gain hands-on experience with common XR interaction patterns and understand how different interaction mechanisms can coexist within the same scene.

In particular, I experimented with:

* Choosing between direct, poke and ray interaction depending on the interaction context
* Coordinating multiple interactors
* Building physical interactions such as opening doors and drawers
* Interacting with world-space UI from VR controllers
* Using sockets for constrained object placement
* Structuring a basic VR scene around reusable interaction components

## Project Status

This is an **early-stage personal prototype** created for learning and experimentation. It is not intended to represent a production-ready VR application.

The repository documents my practical exploration of Unity XR interaction concepts and serves as a foundation for further interactive and immersive prototypes.
