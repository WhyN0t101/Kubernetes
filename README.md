# Custom Kubernetes Manager

A C# Windows Forms application that provides a graphical user interface for managing Kubernetes resources. This tool simplifies Kubernetes cluster management by offering an intuitive desktop interface for common operations.

## Description

This project aims to create an easy-to-use distributed solution for any application using Docker and Kubernetes. The goal is to ensure this capability for large-scale solutions in any ecosystem.

In this context, an orchestration layer must be utilized to intelligently coordinate a set of servers and containers, keep track of the current state of all servers and associated resources, and maintain an inventory of all running containers.

Among the various solutions for orchestrating these resources, we focus on Kubernetes within the scope of this project.

## Objective

The primary objective is to design and implement a desktop application that serves as a frontend for managing resources provided through the Kubernetes orchestrator. The application provides a user-friendly interface for:
- Managing Kubernetes deployments
- Monitoring pods and their metrics
- Managing services and ingresses
- Namespace management
- Node monitoring and management

## Features

- **Cluster Management**: Connect to and manage multiple Kubernetes clusters
- **Deployment Operations**: Create, update, and delete deployments
- **Pod Monitoring**: View pod status, logs, and resource usage
- **Service Management**: Manage Kubernetes services and endpoints
- **Namespace Operations**: Create and manage namespaces
- **Node Information**: Monitor node status and resources
- **Ingress Management**: Configure and manage ingress resources
- **Metrics Visualization**: View resource metrics for pods and nodes
- **Configuration Wizard**: Easy setup wizard for cluster connection

## Technology Stack

- **C# .NET Framework** - Core application development
- **Windows Forms** - Desktop GUI framework
- **Kubernetes Client SDK** - Kubernetes API interaction
- **Docker** - Container platform
- **Kubernetes** - Container orchestration platform

## Prerequisites

Ensure you have the following installed:

- **Visual Studio 2022** or later
- **.NET Framework** (4.7.2 or higher)
- **Docker Desktop** (with Kubernetes enabled) or access to a Kubernetes cluster
- **kubectl** - Kubernetes command-line tool (optional, for verification)

### Kubernetes Cluster

You need access to a Kubernetes cluster. Options include:
- **Docker Desktop** - Enable Kubernetes in settings (easiest for local development)
- **Minikube** - Local Kubernetes cluster
- **Cloud Providers** - Azure AKS, Google GKE, Amazon EKS
- **On-premises** - Existing Kubernetes cluster

## Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/WhyN0t101/Custom-Kubernetes-Manager.git
   cd Custom-Kubernetes-Manager
   ```

2. **Open the solution in Visual Studio**
   - Open `Kubernetes.sln` in Visual Studio 2022

3. **Restore NuGet packages**
   - Right-click on the solution in Solution Explorer
   - Select "Restore NuGet Packages"
   - Or use: `Tools > NuGet Package Manager > Restore`

4. **Build the solution**
   - Press `Ctrl+Shift+B` or select `Build > Build Solution`

5. **Run the application**
   - Press `F5` or click "Start" in Visual Studio

## Configuration

### Connecting to a Kubernetes Cluster

1. **Using Docker Desktop (Recommended for beginners)**
   - Install Docker Desktop
   - Enable Kubernetes in Docker Desktop settings
   - Wait for Kubernetes to start
   - Run the application - it will automatically detect the local cluster

2. **Using Minikube**
   ```bash
   minikube start
   ```
   - The application will use your local kubeconfig

3. **Using Remote Cluster**
   - Ensure you have a valid `kubeconfig` file
   - Default location: `~/.kube/config` (Windows: `%USERPROFILE%\.kube\config`)
   - The application will read this configuration automatically

### First Run

When you first run the application:
1. The Configuration Wizard will guide you through cluster setup
2. Select your cluster context
3. Verify connection to the cluster
4. Start managing your Kubernetes resources

## Usage

### Main Window

The main window provides access to all Kubernetes resource management features:

- **Deployments Tab**: View, create, update, and delete deployments
- **Pods Tab**: Monitor pod status, view logs, and check resource usage
- **Services Tab**: Manage Kubernetes services
- **Namespaces Tab**: Create and switch between namespaces
- **Nodes Tab**: View node information and status
- **Ingress Tab**: Configure ingress resources

### Common Operations

#### Creating a Deployment
1. Navigate to the Deployments tab
2. Click "Create Deployment"
3. Fill in deployment details (name, image, replicas)
4. Click "Create"

#### Viewing Pod Logs
1. Navigate to the Pods tab
2. Select a pod from the list
3. Click "View Logs"

#### Managing Namespaces
1. Navigate to the Namespaces tab
2. Click "Create Namespace" to create new namespaces
3. Select a namespace to switch context


## Troubleshooting

### Cannot Connect to Kubernetes Cluster

**Issue**: Application can't connect to the cluster

**Solutions**:
- Verify Kubernetes is running: `kubectl cluster-info`
- Check your kubeconfig file exists and is valid
- Ensure Docker Desktop Kubernetes is enabled (if using Docker Desktop)
- Verify cluster context: `kubectl config current-context`

### Access Denied Errors

**Issue**: Operations fail with permission errors

**Solutions**:
- Verify you have appropriate RBAC permissions on the cluster
- Check your service account has necessary roles
- For local clusters, ensure you're using admin context

### Application Crashes on Startup

**Issue**: Application fails to start

**Solutions**:
- Ensure all NuGet packages are restored
- Verify .NET Framework version compatibility
- Check for missing dependencies in the error log

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the GNU General Public License - see the [LICENSE.txt](LICENSE.txt) file for details.

---

**Note**: This application is designed for educational and development purposes. For production cluster management, consider using `kubectl`, Kubernetes Dashboard, or cloud provider management consoles.
