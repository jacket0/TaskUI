using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
	[SerializeField] private Health _health;

	private void OnEnable()
	{
		_health.ValueChanged += UpdateHealth;
	}

	private void OnDisable()
	{
		_health.ValueChanged -= UpdateHealth;
	}

	protected abstract void UpdateHealth(int health, int maxHealth);
}
