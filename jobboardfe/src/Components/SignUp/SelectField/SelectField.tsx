import React from "react";

interface SelectFieldProps {
    id: string;
    label: string;
    value: string;
    onChange: (e: React.ChangeEvent<HTMLSelectElement>) => void;
    options: { value: string; label: string }[];
    required?: boolean;
}

const SelectField: React.FC<SelectFieldProps> = ({
    id,
    label,
    value,
    onChange,
    options,
    required = false,
}) => {
    return (
        <div className="space-y-1">
            <label htmlFor={id} className="text-sm text-gray-900">
                {label}
            </label>
            <select
                id={id}
                value={value}
                onChange={onChange}
                required={required}
                className="h-12 w-full px-3 bg-white border border-gray-300 text-gray-900 rounded-lg focus:outline-none focus:border-purple-500 focus:ring-1 focus:ring-purple-500"
            >
                <option value="" disabled hidden>
                    Select your role
                </option>
                {options.map((opt) => (
                    <option key={opt.value} value={opt.value}>
                        {opt.label}
                    </option>
                ))}
            </select>
        </div>
    );
};

export default SelectField;
