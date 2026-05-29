Chatbot GUI with Memory & Sentiment Detection

- Overview

This project is a C# Windows Forms chatbot application built in Visual Studio.

It demonstrates how to combine a graphical user interface (GUI) with chatbot logic, memory features, and sentiment detection to create a more interactive and human‑like experience.

Features

GUI Layout

ASCII art panel styled with Consolas font at the top.

Chat panel with styled chat bubbles for user and bot messages.
  
Close button event handler (`CloseButton_Click`) to exit the application.

Chat Bubbles

Custom design for user vs bot messages.
  
Messages dock dynamically in the chat panel.
  
Provides a clean, messenger‑style interface.

Memory Integration

Stores user’s name and favourite topic.

Personalized greetings and responses based on stored memory.

Sentiment Detection

Detects moods from user input using keyword matching.

Categories: worried, happy, frustrated, curious.

Chatbot adapts tone accordingly (empathetic, cheerful, supportive).

  Fallback Responses
  
  If input doesn’t match memory or sentiment, chatbot replies with jokes, fun facts, or casual conversation.
  Ensures the chatbot never feels “stuck.”

 File Structure


