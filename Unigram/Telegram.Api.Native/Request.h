#pragma once
#include <wrl.h>
#include "Telegram.Api.Native.h"

using namespace Microsoft::WRL;
using namespace Microsoft::WRL::Wrappers;
using ABI::Telegram::Api::Native::ITLObject;
using ABI::Telegram::Api::Native::ConnectionType;
using ABI::Telegram::Api::Native::ISendRequestCompletedCallback;
using ABI::Telegram::Api::Native::IRequestQuickAckReceivedCallback;

namespace ABI
{
	namespace Telegram
	{
		namespace Api
		{
			namespace Native
			{

				MIDL_INTERFACE("F310910A-64AF-454C-9A39-E2785D0FD4C0") IRequest : public IUnknown
				{
				public:
					virtual HRESULT STDMETHODCALLTYPE get_Object(_Out_ ITLObject** value) = 0;
					virtual HRESULT STDMETHODCALLTYPE get_Token(_Out_ INT32* value) = 0;
					virtual HRESULT STDMETHODCALLTYPE get_ConnectionType(_Out_ ConnectionType* value) = 0;
					virtual HRESULT STDMETHODCALLTYPE get_DatacenterId(_Out_ UINT32* value) = 0;
				};

			}
		}
	}
}


using ABI::Telegram::Api::Native::IRequest;

namespace Telegram
{
	namespace Api
	{
		namespace Native
		{

			class Request WrlSealed : public RuntimeClass<RuntimeClassFlags<ClassicCom>, IRequest>
			{
				friend class ConnectionManager;

			public:
				Request(_In_ ITLObject* object, INT32 token, ConnectionType connectionType, UINT32  datacenterId, _In_ ISendRequestCompletedCallback* sendCompletedCallback, _In_ IRequestQuickAckReceivedCallback* quickAckReceivedCallback);
				~Request();

				//COM exported methods
				IFACEMETHODIMP get_Object(_Out_ ITLObject** value);
				IFACEMETHODIMP get_Token(_Out_ INT32* value);
				IFACEMETHODIMP get_ConnectionType(_Out_ ConnectionType* value);
				IFACEMETHODIMP get_DatacenterId(_Out_ UINT32* value);

				//Internal methods
				inline ITLObject* GetObject() const
				{
					return m_object.Get();
				}

				inline INT32 GetToken() const
				{
					return m_token;
				}

				inline ConnectionType GetConnectionType() const
				{
					return m_connectionType;
				}

				inline UINT32 GetDatacenterId() const
				{
					return m_datacenterId;
				}

			private:
				INT32 m_token;
				ConnectionType m_connectionType;
				UINT32 m_datacenterId;
				ComPtr<ITLObject> m_object;
				ComPtr<ISendRequestCompletedCallback> m_sendCompletedCallback;
				ComPtr<IRequestQuickAckReceivedCallback> m_quickAckReceivedCallback;
			};

		}
	}
}