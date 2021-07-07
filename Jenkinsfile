pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                sh 'echo "Building..."'
                sh 'MSBUILD test-project.csproj'
            }
        }
        stage('Test') {
            steps {
                sh 'echo Test'
            }
        }
    }    
}