class Task {
    private string taskName;
    private bool taskComplete;
    private string taskDuration;

        public bool isComplete() {
            return taskComplete;
        }

        public string getTaskName() {
            return taskName;
        }

        public string getDuration() {
            return taskDuration;
        }
 
        public void setComplete() {
                taskComplete = true;

        }

        public void setTaskName(string task) {
            taskName = task;
        }

        public void setDuration(string time) {
            taskDuration = time;
        }

        public Task(string addtask, string taskTime) {
            taskName = addtask;
            taskDuration = taskTime;
            taskComplete = false;
        }
}