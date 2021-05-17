package com.aptech.springrestapi.restservice.message;
import org.slf4j.*;

import java.util.concurrent.atomic.AtomicInteger;
//POJO Plain Object Java Object
public class RedisReceiver {
    private static final Logger LOGGER = LoggerFactory.getLogger(RedisReceiver.class);
    private AtomicInteger counter = new AtomicInteger();
    public void receiveMessage(String message) {
        LOGGER.info("Received <" + message + ">");
        counter.incrementAndGet();
    }

    public int getCount() {
        return counter.get();
    }
}
