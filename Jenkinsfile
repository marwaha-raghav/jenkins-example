pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                sh 'echo "Building..."'
                sh 'dotnet test-project.csproj'
            }
        }
        stage('Test') {
            steps {
                sh 'echo Test'
            }
        }
    }    
}