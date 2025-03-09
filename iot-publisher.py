import json
import time
import boto3

# AWS IoT Details
iot_client = boto3.client('iot-data', region_name='us-east-1')  # Change region as needed
topic = "iot/sensor/data"

def publish_sensor_data():
    while True:
        payload = {
            "device_id": "sensor_001",
            "temperature": round(20 + (5 * (time.time() % 10)), 2),
            "humidity": round(50 + (10 * (time.time() % 10)), 2),
            "timestamp": int(time.time())
        }
        
        response = iot_client.publish(
            topic=topic,
            qos=1,
            payload=json.dumps(payload)
        )
        
        print(f"Published: {payload}")
        time.sleep(5)  # Send every 5 seconds

if __name__ == "__main__":
    publish_sensor_data()

