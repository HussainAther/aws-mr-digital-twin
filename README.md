# 🛰️ AWS x Mixed Reality (MR) Digital Twin

🚀 **A cloud-powered Mixed Reality (MR) digital twin project that visualizes real-time IoT sensor data using AWS services, Unity, and NVIDIA Omniverse.**

---

## 🌟 Overview
This project integrates **AWS IoT Core, AWS Lambda, and DynamoDB** with **Unity Mixed Reality (MR) & NVIDIA Omniverse** to create a **real-time digital twin**. The MR application dynamically visualizes sensor data streamed from **IoT devices (or simulated data)**, making it useful for **industrial monitoring, simulation, and smart city applications**.

### **💡 Features**
✅ **AWS IoT & Cloud Backend** – Publishes real-time sensor data to AWS IoT Core.  
✅ **Unity Mixed Reality (AR/VR)** – Displays live IoT data in an immersive environment.  
✅ **NVIDIA Omniverse Integration** – Uses USD format for simulation and collaboration.  
✅ **Serverless Architecture** – AWS Lambda & API Gateway provide scalable backend services.  
✅ **Physics-Based Simulation (Optional)** – Uses NVIDIA **PhysX** for real-world behavior modeling.  

---

## 📌 Project Structure
```
aws-mr-digital-twin/
│── backend/                          # AWS Backend Services
│   ├── iot-publisher.py              # Publishes sensor data to AWS IoT Core
│   ├── lambda-fetch-sensor.py        # AWS Lambda function for fetching sensor data
│   ├── dynamodb-schema.json          # Defines DynamoDB table schema
│   ├── api-gateway-deployment.yaml   # API Gateway configuration (AWS SAM)
│   ├── terraform/                     # Infrastructure as Code (Optional)
│   │   ├── main.tf                    # AWS Terraform setup
│   │   ├── variables.tf                # AWS Variables
│── unity-mr-app/                      # Unity Mixed Reality App
│   ├── Assets/                         # Unity Assets
│   │   ├── Scripts/                     # Unity Scripts
│   │   │   ├── AWSIoTDataFetcher.cs     # Fetches AWS IoT data
│   │   │   ├── DigitalTwinManager.cs    # Controls 3D digital twin behavior
│   │   │   ├── UIUpdater.cs             # Updates UI elements dynamically
│   │   ├── Prefabs/                     # 3D Prefabs for MR visualizations
│   │   │   ├── SensorDisplay.prefab      # UI panel to display sensor data
│   │   ├── Scenes/                      # Unity Scenes
│   │   │   ├── MainScene.unity          # Primary MR scene
│── omniverse/                          # NVIDIA Omniverse Integration
│   ├── omniverse-digital-twin.usd      # USD File for Omniverse compatibility
│   ├── connect-to-nucleus.py           # Script to connect Unity with Omniverse Nucleus
│   ├── physics-simulation-setup.py     # Script for physics interactions with Omniverse PhysX
│── docs/                               # Documentation
│   ├── README.md                        # Project Overview & Setup Guide
│   ├── architecture-diagram.png         # System Architecture Diagram
│   ├── api-endpoints.md                 # API documentation for AWS services
│   ├── omniverse-integration.md         # Guide on Omniverse & USD setup
│── .gitignore                           # Ignore Unity & AWS secrets
│── LICENSE                              # Open-source license (MIT recommended)
```

---

## 🛠️ Setup Instructions

### **1️⃣ AWS Backend Setup**
1. **Create an AWS IoT Thing**
   - Navigate to **AWS IoT Core** and register a new device ("Thing").
   - Create a **certificate** and attach an IoT policy allowing data publishing.

2. **Deploy AWS Services**
   - **DynamoDB**: Create a table `IoT_Sensor_Data` with `device_id` as the partition key.
   - **AWS Lambda**: Deploy `lambda-fetch-sensor.py` to process sensor data.
   - **API Gateway**: Set up an API Gateway to expose Lambda functions to Unity.

3. **Run IoT Data Publisher**
   ```sh
   python backend/iot-publisher.py
   ```

---

### **2️⃣ Unity Mixed Reality Setup**
1. **Install Unity (2021.3+ recommended)**
2. **Import MRTK (for HoloLens) or ARFoundation (for ARKit/ARCore)**
3. **Add Scripts to Unity GameObjects**
   - Attach `AWSIoTDataFetcher.cs` to an empty GameObject.
   - Assign a `TextMeshPro` UI element to display sensor data.
4. **Run the Unity Scene**
   - Press **Play** in Unity to visualize real-time IoT data.

---

### **3️⃣ NVIDIA Omniverse Integration (Optional)**
1. **Install Omniverse Launcher & Omniverse Nucleus**
2. **Run the Omniverse Connection Script**
   ```sh
   python omniverse/connect-to-nucleus.py
   ```
3. **Convert Unity Models to USD Format**
   - Export `.usd` models from Unity to Omniverse.

---

## 🔥 Future Enhancements
💡 **Add AI-powered analytics** – Integrate AWS SageMaker for predictive insights.  
💡 **Deploy on Azure (NV-series GPUs)** – Extend to Azure virtualized graphics.  
💡 **Multi-User Collaboration** – Enable real-time team interactions via Omniverse Cloud.  

---

## 📜 License
MIT License – Free to use and modify! 🚀  

---

## 🏆 Why This Project?  
This project **demonstrates expertise in AWS, Mixed Reality, and Omniverse**, making it an excellent showcase for **cloud-based digital twin & simulation roles at NVIDIA or similar companies**.  

---

## ⭐ Want to Contribute?
Pull requests welcome! 🎯  

---
```

---

