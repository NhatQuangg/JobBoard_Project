import React from "react";

interface PasswordInputProps {
    value: string;
    onChange: (e: React.ChangeEvent<HTMLInputElement>) => void;
    showPassword: boolean;
    toggleShow: () => void;
}

const PasswordInput = ({
    value,
    onChange,
    showPassword,
    toggleShow,
}: PasswordInputProps) => (
    <div className="space-y-1">
        <label htmlFor="password" className="text-sm text-gray-900">
            Password
        </label>
        <div className="relative">
            <input
                id="password"
                type={showPassword ? "text" : "password"}
                placeholder="Enter your password"
                value={value}
                onChange={onChange}
                required
                className="h-12 w-full pr-12 px-3 border border-gray-300 rounded-lg focus:border-purple-500 focus:ring-1 focus:ring-purple-500"
            />
            <button
                type="button"
                onClick={toggleShow}
                className="absolute right-3 top-1/2 -translate-y-1/2 text-gray-600 text-sm"
            >
                {showPassword ? "Hide" : "Show"}
            </button>
        </div>
    </div>
);

export default PasswordInput;
