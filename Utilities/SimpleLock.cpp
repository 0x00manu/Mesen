#include "stdafx.h"
#include <assert.h>
#include "SimpleLock.h"

thread_local std::thread::id SimpleLock::_threadID = std::this_thread::get_id();

SimpleLock::SimpleLock()
{
	_lock.clear();
	_lockCount = 0;
	_holderThreadID = std::thread::id();
}

SimpleLock::~SimpleLock()
{
}

LockHandler SimpleLock::AcquireSafe()
{
	return LockHandler(this);
}

void SimpleLock::Acquire()
{
	if(_lockCount == 0 || _holderThreadID != _threadID) {
		while(_lock.test_and_set());
		_holderThreadID = _threadID;
		_lockCount = 1;
	} else {
		//Same thread can acquire the same lock multiple times
		_lockCount++;
	}
}

bool SimpleLock::IsFree()
{
	if(!_lock.test_and_set()) {
		_lock.clear();
		return true;
	}
	return false;
}

void SimpleLock::WaitForRelease()
{
	//Wait until we are able to grab a lock, and then release it again
	Acquire();
	Release();
}

void SimpleLock::Release()
{
	if(_lockCount > 0 && _holderThreadID == _threadID) {
		_lockCount--;
		if(_lockCount == 0) {
			_holderThreadID = std::thread::id();
			_lock.clear();
		}
	} else {
		assert(false);
	}
}


LockHandler::LockHandler(SimpleLock *lock)
{
	_lock = lock;
	_lock->Acquire();
}

LockHandler::~LockHandler()
{
	_lock->Release();
}